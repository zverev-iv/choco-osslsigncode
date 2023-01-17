$ErrorActionPreference = "Stop";

$packageArgs = @{
  packageName   = $env:ChocolateyPackageName
  unzipLocation = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"
  url           = "${url}"
  url64bit      = "${url64bit}"
  softwareName  = "${softwareName}*"
  checksum      = "${checksum}"
  checksumType  = "${checksumType}"
  checksum64    = "${checksum64}"
  checksumType64= "${checksumType64}"
}

Install-ChocolateyZipPackage @packageArgs
