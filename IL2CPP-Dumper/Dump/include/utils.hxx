#ifndef UTILS_H
#define UTILS_H

#include <string>
#include <windows.h>
#include <fstream>

extern std::ofstream logFile;

void Log( const std::string & msg );

void EnsureDirectory( const std::string & path );

std::string GetAccessModifier( uint32_t flags );

#endif // UTILS_H