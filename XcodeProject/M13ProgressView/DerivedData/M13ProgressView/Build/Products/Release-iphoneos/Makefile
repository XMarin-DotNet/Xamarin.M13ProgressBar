XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=../../../../../../M13ProgressView
PROJECT=$(PROJECT_ROOT)/M13ProgressView.xcodeproj
TARGET=M13ProgressView

all: libM13ProgressView.a

libM13ProgressView-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libM13ProgressView-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@
	
libM13ProgressView-armv64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libM13ProgressView.a: libM13ProgressView-i386.a libM13ProgressView-armv7.a libM13ProgressView-armv64.a
	xcrun -sdk iphoneos lipo -create -output $@ $^

clean:
	-rm -f *.a *.dll