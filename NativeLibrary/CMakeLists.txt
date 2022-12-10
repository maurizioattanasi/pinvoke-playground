cmake_minimum_required(VERSION 3.25.1)

project(native LANGUAGES CXX)

if(MSVC)
    set(CMAKE_WINDOWS_EXPORT_ALL_SYMBOLS ON)
endif()

add_library(native SHARED)
target_include_directories(native PRIVATE "$PROJECT_SOURCE_DIR")

add_subdirectory("greeter")

add_executable(app)
target_sources(app PRIVATE "example/app.cpp")
target_link_libraries(app PRIVATE native)

set(CMAKE_BINARY_DIR  "../../bin")

install(TARGETS native 
        FILE_SET HEADERS)