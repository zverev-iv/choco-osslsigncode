$ErrorActionPreference = "Stop";

$packageArgs = @{
  packageName   = $env:ChocolateyPackageName
  unzipLocation = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"
  url64bit      = "${url64bit}"
  softwareName  = "${softwareName}*"
  checksum64    = "${checksum64}"
  checksumType64= "${checksumType64}"
}

Install-ChocolateyZipPackage @packageArgs