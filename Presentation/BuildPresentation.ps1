<#
  Build the presentation for the tech talk.
#>
$buildDir = "$PSScriptRoot\..\.build"
if (Test-Path $buildDir) {
  Remove-Item -Force -Recurse $buildDir
}
New-Item -ItemType Directory -Force -Path $buildDir >$null

pushd $buildDir
pdflatex $PSScriptRoot\TechTalkDotNetMemoryLeak
popd
biber TechTalkDotNetMemoryLeak --output-directory $buildDir
pushd $buildDir
pdflatex $PSScriptRoot\TechTalkDotNetMemoryLeak
popd
Copy-Item $builddir\TechTalkDotNetMemoryLeak.pdf $PSScriptRoot\..
