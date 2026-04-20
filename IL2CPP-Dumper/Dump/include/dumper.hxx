#ifndef DUMPER_H
#define DUMPER_H

#include <vector>
#include "il2cpp_image.hxx"

class Dumper {

public:
    std::vector<Il2CppImage> images;

    Dumper( );

    void DumpAssembly( const Il2CppImage & img, bool aiMode );
    void DumpAllToFiles( );

};

#endif // DUMPER_H