#include "../include/utils.hxx"
#include <iostream>
#include <direct.h>
#include <algorithm>

std::ofstream logFile( "C:\\IL2CPPDump_Log.txt" );


void Log( const std::string & msg ) {
    std::cout << msg << "\n";
    logFile << msg << "\n";
    logFile.flush( );
}


void EnsureDirectory( const std::string & path ) {
    _mkdir( path.c_str( ) );
}


std::string GetAccessModifier( uint32_t flags ) {
    uint32_t access = flags & 0x0007;

    switch ( access ) {
        case 0x0006: return "public";
        case 0x0001: return "private";
        case 0x0004: return "protected";
        case 0x0005: return "protected internal";
        default:     return "private";
    }
}