#define _CRT_SECURE_NO_WARNINGS

#include <windows.h>
#include <iostream>
#include "../include/utils.hxx"
#include "../include/dumper.hxx"


FILE * Startup( ) {
    AllocConsole( );

    FILE * fDummy = nullptr;
    freopen_s( &fDummy, "CONOUT$", "w", stdout );
    freopen_s( &fDummy, "CONIN$", "r", stdin );

    SetConsoleTitleA( "IL2CPP Dumper - Press INSERT" );

    return fDummy;
}


DWORD WINAPI EntryPoint( LPVOID lpParam ) {
    HMODULE hModule = ( HMODULE ) lpParam;
    FILE * output = Startup( );

    Log( "DLL injected. Press INSERT to dump..." );

    while ( true ) {
        if ( GetAsyncKeyState( VK_INSERT ) & 0x8000 ) {
            Log( "INSERT -> starting dump..." );
            Sleep( 300 );

            Dumper dumper;

            if ( dumper.images.empty( ) ) {
                Log( "[ERROR] No images/assemblies found" );
            } else {
                Log( "[OK] Found " + std::to_string( dumper.images.size( ) ) + " assemblies" );
                dumper.DumpAllToFiles( );
            }

            break;
        }

        Sleep( 50 );
    }

    Log( "Dump finished." );
    std::cin.get( );

    if ( output ) fclose( output );
    FreeConsole( );

    FreeLibraryAndExitThread( hModule, 0 );
    return 0;
}


BOOL APIENTRY DllMain( HMODULE hModule, DWORD reason, LPVOID lpReserved ) {
    switch ( reason ) {
        case DLL_PROCESS_ATTACH:
            DisableThreadLibraryCalls( hModule );
            CreateThread( nullptr, 0, EntryPoint, hModule, 0, nullptr );
            break;
    }

    return TRUE;
}