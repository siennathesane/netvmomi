#!/bin/bash
set -xe

dotnet restore --no-cache
dotnet build --configuration "$buildConfiguration"
dotnet pack --configuration "$buildConfiguration"

PROJECTS=( Api Model Client )

for i in "${PROJECTS[@]}"
do
	pushd $PWD/src/$i/bin/"$buildConfiguration"/
	CURRENT_PACKAGE="$(ls *.nupkg)"
	dotnet nuget push $CURRENT_PACKAGE -s https://nuget.org -k $NUGET_API_KEY
	popd
done
