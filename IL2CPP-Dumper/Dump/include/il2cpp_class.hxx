#ifndef IL2CPP_CLASS_H
#define IL2CPP_CLASS_H

#include <vector>
#include <string>
#include <tuple>
#include "il2cpp_api.hxx"

class Il2CppClass {

public:
    void * klass = nullptr;

    explicit Il2CppClass( void * k = nullptr ): klass( k ) { }

    const char * GetName( ) const;
    const char * GetNamespace( ) const;

    bool IsValueType( ) const;
    bool IsInterface( ) const;

    uint32_t GetFlags( ) const;
    uint32_t GetTypeToken( ) const;

    Il2CppClass GetParent( ) const;
    std::vector<Il2CppClass> GetInterfaces( ) const;


    using FieldInfo = std::tuple<uint32_t, std::string, std::string, int32_t>;
    std::vector<FieldInfo> GetFields( ) const;


    using ParamInfo = std::pair<std::string, std::string>;
    using MethodInfo = std::tuple<uint32_t, std::string, std::string, std::vector<ParamInfo>, uintptr_t>;
    std::vector<MethodInfo> GetMethods( ) const;

};

#endif // IL2CPP_CLASS_H