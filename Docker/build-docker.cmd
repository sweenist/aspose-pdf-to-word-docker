@ECHO OFF

ECHO Building 1803 docker image
docker build -f Windows1803.Dockerfile -t 1803-pdf-to-word ..\PdfToWordConsole\bin\Release\net462
ECHO.
ECHO Building 1909 docker image
docker build -f Windows1909.Dockerfile -t 1909-pdf-to-word ..\PdfToWordConsole\bin\Release\net462

PAUSE