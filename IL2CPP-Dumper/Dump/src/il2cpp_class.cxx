#include "../include/il2cpp_class.hxx"
#include "../include/il2cpp_api.hxx"


const char * Il2CppClass::GetName( ) const {
    return api::class_get_name && klass ? api::class_get_name( klass ) : "Unknown";
}


const char * Il2CppClass::GetNamespace( ) const {
    return api::class_get_namespace && klass ? api::class_get_namespace( klass ) : "";
}


bool Il2CppClass::IsValueType( ) const {
    return api::class_is_valuetype && klass ? api::class_is_valuetype( klass ) : false;
}


bool Il2CppClass::IsInterface( ) const {
    return api::class_is_interface && klass ? api::class_is_interface( klass ) : false;
}


uint32_t Il2CppClass::GetFlags( ) const {
    return api::class_get_flags && klass ? api::class_get_flags( klass ) : 0;
}


uint32_t Il2CppClass::GetTypeToken( ) const {
    return api::class_get_type_token && klass ? api::class_get_type_token( klass ) : 0;
}


Il2CppClass Il2CppClass::GetParent( ) const {
    return Il2CppClass( api::class_get_parent && klass ? api::class_get_parent( klass ) : nullptr );
}


std::vector<Il2CppClass> Il2CppClass::GetInterfaces( ) const {
    std::vector<Il2CppClass> ifaces;

    if ( !klass || !api::class_get_interfaces ) {
        return ifaces;
    }

    void * iter = nullptr;
    while ( auto iface = api::class_get_interfaces( klass, &iter ) ) {
        if ( !iface ) break;
        ifaces.emplace_back( iface );
    }

    return ifaces;
}


std::vector<Il2CppClass::FieldInfo> Il2CppClass::GetFields( ) const {
    std::vector<FieldInfo> fields;

    if ( !klass || !api::class_get_fields ) {
        return fields;
    }

    void * iter = nullptr;
    while ( auto field = api::class_get_fields( klass, &iter ) ) {
        if ( !field ) break;

        const char * name = api::field_get_name ? api::field_get_name( field ) : nullptr;
        if ( !name || !*name ) continue;

        int32_t offset = api::field_get_offset ? api::field_get_offset( field ) : -1;
        uint32_t flags = api::field_get_flags ? api::field_get_flags( field ) : 0;

        void * ftype = api::field_get_type ? api::field_get_type( field ) : nullptr;
        const char * tname = ftype && api::type_get_name ? api::type_get_name( ftype ) : "object";

        fields.emplace_back( flags, tname, name, offset );
    }

    return fields;
}


std::vector<Il2CppClass::MethodInfo> Il2CppClass::GetMethods( ) const {
    std::vector<MethodInfo> methods;

    if ( !klass || !api::class_get_methods ) {
        return methods;
    }

    void * iter = nullptr;
    while ( auto method = api::class_get_methods( klass, &iter ) ) {
        if ( !method ) break;

        const char * mname = api::method_get_name ? api::method_get_name( method ) : nullptr;
        if ( !mname || !*mname ) continue;

        uint32_t flags = 0;
        if ( api::method_get_flags ) api::method_get_flags( method, &flags );

        void * rtype = api::method_get_return_type ? api::method_get_return_type( method ) : nullptr;
        const char * rtname = rtype && api::type_get_name ? api::type_get_name( rtype ) : "void";

        uintptr_t methodAddr = 0;
        if ( api::method_get_pointer ) {
            void * ptr = api::method_get_pointer( method );
            methodAddr = reinterpret_cast<uintptr_t>( ptr );
        } else {
            // fallback
            void * ptr = *reinterpret_cast<void **>( method );
            methodAddr = reinterpret_cast<uintptr_t>( ptr );
        }

        uint32_t pcount = api::method_get_param_count ? api::method_get_param_count( method ) : 0;

        std::vector<ParamInfo> params;
        for ( uint32_t i = 0; i < pcount; ++i ) {
            const void * ptype = api::method_get_param ? api::method_get_param( method, i ) : nullptr;
            const char * ptname = ptype && api::type_get_name ? api::type_get_name( const_cast< void * >( ptype ) ) : "object";

            const char * pname = api::method_get_param_name ? api::method_get_param_name( method, i ) : nullptr;

            params.emplace_back(
                ptname ? ptname : "object",
                pname ? pname : ( "arg" + std::to_string( i ) ).c_str( )
            );
        }

        methods.emplace_back( flags, rtname ? rtname : "void", mname, std::move( params ), methodAddr );
    }

    return methods;
}