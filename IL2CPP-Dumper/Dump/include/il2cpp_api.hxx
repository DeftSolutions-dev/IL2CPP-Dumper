#ifndef IL2CPP_API_H
#define IL2CPP_API_H

#include <cstddef>
#include <cstdint>

namespace api {

    extern bool initialized;
    extern uintptr_t gameAssemblyBase;

    // function pointer types
    typedef void * ( __fastcall * get_domain_t )( );
    typedef void ** ( __fastcall * get_assemblies_t )( void * domain, size_t * count );
    typedef void * ( __fastcall * assembly_get_image_t )( void * assembly );
    typedef const char * ( __fastcall * image_get_name_t )( void * image );
    typedef size_t( __fastcall * image_get_class_count_t )( void * image );
    typedef void * ( __fastcall * image_get_class_t )( void * image, size_t index );

    typedef const char * ( __fastcall * class_get_name_t )( void * klass );
    typedef const char * ( __fastcall * class_get_namespace_t )( void * klass );
    typedef uint32_t( __fastcall * class_get_flags_t )( void * klass );
    typedef void * ( __fastcall * class_get_parent_t )( void * klass );
    typedef bool( __fastcall * class_is_valuetype_t )( void * klass );
    typedef bool( __fastcall * class_is_interface_t )( void * klass );
    typedef void * ( __fastcall * class_get_interfaces_t )( void * klass, void ** iter );

    typedef size_t( __fastcall * class_num_fields_t )( void * klass );
    typedef void * ( __fastcall * class_get_fields_t )( void * klass, void ** iter );
    typedef const char * ( __fastcall * field_get_name_t )( void * field );
    typedef void * ( __fastcall * field_get_type_t )( void * field );
    typedef uint32_t( __fastcall * field_get_flags_t )( void * field );
    typedef int32_t( __fastcall * field_get_offset_t )( void * field );

    typedef void * ( __fastcall * class_get_methods_t )( void * klass, void ** iter );
    typedef const char * ( __fastcall * method_get_name_t )( void * method );
    typedef uint32_t( __fastcall * method_get_flags_t )( void * method, uint32_t * iflags );
    typedef uint32_t( __fastcall * method_get_param_count_t )( void * method );
    typedef const void * ( __fastcall * method_get_param_t )( void * method, uint32_t index );
    typedef const char * ( __fastcall * method_get_param_name_t )( void * method, uint32_t index );
    typedef void * ( __fastcall * method_get_return_type_t )( void * method );
    typedef void * ( __fastcall * method_get_pointer_t )( void * method );

    typedef const char * ( __fastcall * type_get_name_t )( void * type );
    typedef uint32_t( __fastcall * class_get_type_token_t )( void * klass );


    extern get_domain_t get_domain;
    extern get_assemblies_t get_assemblies;
    extern assembly_get_image_t assembly_get_image;
    extern image_get_name_t image_get_name;
    extern image_get_class_count_t image_get_class_count;
    extern image_get_class_t image_get_class;

    extern class_get_name_t class_get_name;
    extern class_get_namespace_t class_get_namespace;
    extern class_get_flags_t class_get_flags;
    extern class_get_parent_t class_get_parent;
    extern class_is_valuetype_t class_is_valuetype;
    extern class_is_interface_t class_is_interface;
    extern class_get_interfaces_t class_get_interfaces;

    extern class_num_fields_t class_num_fields;
    extern class_get_fields_t class_get_fields;
    extern field_get_name_t field_get_name;
    extern field_get_type_t field_get_type;
    extern field_get_flags_t field_get_flags;
    extern field_get_offset_t field_get_offset;

    extern class_get_methods_t class_get_methods;
    extern method_get_name_t method_get_name;
    extern method_get_flags_t method_get_flags;
    extern method_get_param_count_t method_get_param_count;
    extern method_get_param_t method_get_param;
    extern method_get_param_name_t method_get_param_name;
    extern method_get_return_type_t method_get_return_type;
    extern method_get_pointer_t method_get_pointer;

    extern type_get_name_t type_get_name;
    extern class_get_type_token_t class_get_type_token;


    void init( );

}

#endif // IL2CPP_API_H