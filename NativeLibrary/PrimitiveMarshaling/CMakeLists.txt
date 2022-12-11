target_sources(native 
    PRIVATE calculator.cpp strings.cpp
    PUBLIC FILE_SET HEADERS 
    BASE_DIRS ${PROJECT_SOURCE_DIR}
    FILES calculator.h strings.h)