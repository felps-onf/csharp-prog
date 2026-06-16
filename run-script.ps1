Param(
    [Parameter(Mandatory=$true)][string]$File
)

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Definition
if (-not (Test-Path $File)) {
    Write-Error "Arquivo não encontrado: $File"
    exit 1
}

Push-Location $scriptDir
# Run the locally-installed dotnet-script tool
dotnet tool run dotnet-script -- $File
$exitCode = $LASTEXITCODE
Pop-Location
exit $exitCode
