cmake_minimum_required(VERSION 3.10)
project(EsunnyTapApi)

# 设置C++标准
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)

# 包含目录
# include_directories(${CMAKE_SOURCE_DIR}/include)

# 源文件
set(SOURCES
    ${CMAKE_SOURCE_DIR}/swig_wrap.cxx
)

# 生成动态库
add_library(EsunnyTapApi SHARED ${SOURCES})

# 第三方库位置
if(WIN32)
    set(LIB_PATH ${CMAKE_SOURCE_DIR}/../EsunnyTap.Net/runtimes/win-x64/native)
else(UNIX)
    set(LIB_PATH ${CMAKE_SOURCE_DIR}/../EsunnyTap.Net/runtimes/linux-x64/native)
endif()
    
message(STATUS "LIB_PATH: ${LIB_PATH}")

# 链接第三方库
target_link_directories(EsunnyTapApi PRIVATE ${LIB_PATH})
target_link_libraries(EsunnyTapApi PRIVATE
    TapTradeAPI
    TapQuoteAPI
)

# 输出目录
set_target_properties(EsunnyTapApi PROPERTIES
    LIBRARY_OUTPUT_DIRECTORY ${LIB_PATH}
    RUNTIME_OUTPUT_DIRECTORY ${LIB_PATH}
    LIBRARY_OUTPUT_DIRECTORY_RELEASE ${LIB_PATH}
    RUNTIME_OUTPUT_DIRECTORY_RELEASE ${LIB_PATH}
)

message(STATUS "Building for: ${CMAKE_SYSTEM_NAME}")
