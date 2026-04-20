#include "../include/dumper.hxx"
#include "../include/il2cpp_api.hxx"
#include "../include/utils.hxx"
#include <fstream>
#include <map>
#include <iomanip>
#include <algorithm>


Dumper::Dumper( ) {
    api::init( );
    Sleep( 500 );
    if ( !api::initialized ) {
        return;
    }

    void * domain = api::get_domain( );
    if ( !domain ) {
        Log( "[ERROR] No domain" );
        return;
    }

    size_t count = 0;
    void ** assemblies = api::get_assemblies( domain, &count );
    if ( !assemblies || count == 0 ) {
        Log( "[ERROR] No assemblies" );
        return;
    }

    for ( size_t i = 0; i < count; ++i ) {
        void * ass = assemblies[ i ];
        if ( !ass ) continue;

        void * img = api::assembly_get_image( ass );
        if ( !img ) continue;

        const char * name = api::image_get_name( img );
        if ( !name || !*name ) continue;

        images.emplace_back( img );
    }
}


void Dumper::DumpAssembly( const Il2CppImage & img, bool aiMode ) {
    std::string asmName = img.GetName( );

    std::string safeName = asmName;
    std::replace( safeName.begin( ), safeName.end( ), '.', '_' );
    std::replace( safeName.begin( ), safeName.end( ), '-', '_' );

    std::string folder = aiMode ? "C:\\IL2CPP_Dump_AI\\" : "C:\\IL2CPP_Dump_Normal\\";
    EnsureDirectory( folder );

    std::string filename = folder + asmName + ".cs";
    std::ofstream out( filename, std::ios::out );

    if ( !out.is_open( ) ) {
        Log( "Failed to open: " + filename );
        return;
    }

    uintptr_t baseAddr = api::gameAssemblyBase;

    out << "// ========================================================\n";
    out << "// Dumped by @desirepro\n";
    out << "// Assembly: " << asmName << "\n";
    out << "// Classes:  " << img.GetClassCount( ) << "\n";
    out << "// ImageBase: 0x" << std::hex << std::uppercase << baseAddr << "\n";
    out << "// Date:     " << __DATE__ << " " << __TIME__ << "\n";
    out << "// ========================================================\n\n";

    if ( aiMode ) {
        out << "# AI-FRIENDLY STRUCTURED DUMP\n";
        out << "# Optimized for LLM parsing / code generation\n\n";
    } else {
        out << "using System;\n";
        out << "using System.Collections.Generic;\n\n";
    }

    std::map<std::string, std::vector<Il2CppClass>> ns_classes;

    for ( size_t i = 0; i < img.GetClassCount( ); ++i ) {
        auto cls = img.GetClassByIndex( i );
        if ( !cls.klass ) continue;

        std::string name = cls.GetName( );
        if ( name.find( '<' ) != std::string::npos ) continue;  // skip generics

        ns_classes[ cls.GetNamespace( ) ].push_back( cls );
    }

    for ( const auto & [ns, classes] : ns_classes ) {
        if ( !aiMode && !ns.empty( ) ) {
            out << "namespace " << ns << "\n";
            out << "{\n\n";
        }

        for ( const auto & cls : classes ) {
            uint32_t token = cls.GetTypeToken( );
            bool isInterface = cls.IsInterface( );
            bool isStruct = cls.IsValueType( ) && !isInterface;
            std::string type = isInterface ? "interface" : ( isStruct ? "struct" : "class" );

            if ( aiMode ) {
                out << "CLASS: " << ( ns.empty( ) ? "" : ns + "." ) << cls.GetName( ) << "\n";
                out << "TYPE:  " << type << "\n";
                out << "TOKEN: 0x" << std::hex << std::uppercase << token << "\n";

                auto parent = cls.GetParent( );
                if ( parent.klass ) {
                    std::string pn = parent.GetName( );
                    if ( pn != "Object" && pn != "ValueType" && pn != "Enum" ) {
                        out << "EXTENDS: " << pn << "\n";
                    }
                }

                out << "FIELDS:\n";
                for ( const auto & f : cls.GetFields( ) ) {
                    uint32_t ff; std::string ft, fn; int32_t off;
                    std::tie( ff, ft, fn, off ) = f;

                    std::string access = GetAccessModifier( ff );
                    std::string mods = ( ff & 0x0010 ) ? "static " : "";
                    if ( ff & 0x0020 ) mods += "readonly ";

                    out << "  " << std::left << std::setw( 10 ) << access
                        << std::setw( 8 ) << mods
                        << std::setw( 32 ) << ft
                        << fn
                        << "  // 0x" << std::hex << off << "\n";
                }

                out << "METHODS:\n";
                for ( const auto & m : cls.GetMethods( ) ) {
                    uint32_t mf; std::string rt, mn; std::vector<Il2CppClass::ParamInfo> ps; uintptr_t addr;
                    std::tie( mf, rt, mn, ps, addr ) = m;

                    uintptr_t rva = ( addr > baseAddr && baseAddr != 0 ) ? addr - baseAddr : 0;

                    out << "  [RVA: 0x" << std::hex << std::uppercase << rva << "] "
                        << rt << " " << mn << "(";

                    for ( size_t j = 0; j < ps.size( ); ++j ) {
                        if ( j > 0 ) out << ", ";
                        out << ps[ j ].first << " " << ps[ j ].second;
                    }
                    out << ")\n";
                }

                out << "END_CLASS\n\n";
            } else {
                out << "    // TypeToken: 0x" << std::hex << std::uppercase << token << "\n";
                out << "    public " << type << " " << cls.GetName( );

                auto parent = cls.GetParent( );
                std::string pn = parent.GetName( );
                if ( parent.klass && pn != "Object" && pn != "ValueType" && pn != "Enum" ) {
                    out << " : " << pn;
                }

                auto ifaces = cls.GetInterfaces( );
                if ( !ifaces.empty( ) ) {
                    out << ( parent.klass ? ", " : " : " );
                    for ( size_t j = 0; j < ifaces.size( ); ++j ) {
                        if ( j > 0 ) out << ", ";
                        out << ifaces[ j ].GetName( );
                    }
                }
                out << "\n    {\n";

                auto fields = cls.GetFields( );
                if ( !fields.empty( ) ) {
                    out << "        // Fields\n";
                    for ( const auto & f : fields ) {
                        uint32_t ff; std::string ft, fn; int32_t off;
                        std::tie( ff, ft, fn, off ) = f;

                        std::string acc = GetAccessModifier( ff );
                        std::string mods = ( ff & 0x0010 ) ? "static " : "";
                        if ( ff & 0x0020 ) mods += "readonly ";

                        out << "        " << acc << " " << mods << ft << " " << fn << ";";
                        out << "        // 0x" << std::hex << off << "\n";
                    }
                    out << "\n";
                }

                auto methods = cls.GetMethods( );
                if ( !methods.empty( ) ) {
                    out << "        // Methods\n";
                    for ( const auto & m : methods ) {
                        uint32_t mf; std::string rt, mn; std::vector<Il2CppClass::ParamInfo> ps; uintptr_t addr;
                        std::tie( mf, rt, mn, ps, addr ) = m;

                        uintptr_t rva = ( addr > baseAddr && baseAddr != 0 ) ? addr - baseAddr : 0;

                        std::string acc = GetAccessModifier( mf );
                        std::string mods = ( mf & 0x0010 ) ? "static " : "";
                        if ( mf & 0x0040 ) mods += "virtual ";

                        out << "        // RVA: 0x" << std::hex << std::uppercase << rva
                            << " VA: 0x" << addr << "\n";
                        out << "        " << acc << " " << mods << rt << " " << mn << "(";

                        for ( size_t j = 0; j < ps.size( ); ++j ) {
                            if ( j > 0 ) out << ", ";
                            out << ps[ j ].first << " " << ps[ j ].second;
                        }

                        out << ") { }\n\n";
                    }
                }

                out << "    }\n\n";
            }
        }

        if ( !aiMode && !ns.empty( ) ) {
            out << "}\n\n";
        }
    }

    out.close( );
    Log( "Saved -> " + filename + ( aiMode ? "  [AI mode]" : "  [C# mode]" ) );
}


void Dumper::DumpAllToFiles( ) {
    EnsureDirectory( "C:\\IL2CPP_Dump_Normal" );
    EnsureDirectory( "C:\\IL2CPP_Dump_AI" );

    for ( const auto & img : images ) {
        std::string name = img.GetName( );
        Log( "Dumping assembly: " + name + " ..." );

        DumpAssembly( img, false );
        DumpAssembly( img, true );
    }

    Log( "\nDone!" );
    Log( "  Normal (C#):     C:\\IL2CPP_Dump_Normal\\" );
    Log( "  AI-friendly:     C:\\IL2CPP_Dump_AI\\" );
    Log( "" );
}