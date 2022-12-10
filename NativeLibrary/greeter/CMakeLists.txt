target_sources(native 
    PRIVATE greeter.cpp 
    PUBLIC FILE_SET HEADERS 
    BASE_DIRS ${PROJECT_SOURCE_DIR}
    FILES greeter.h)