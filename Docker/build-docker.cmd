docker build -f Windows1803.Dockerfile -t 1803-pdf-to-word ..\PdfToWord\bin\Release\net462
docker build -f Windows1909.Dockerfile -t 1909-pdf-to-word ..\PdfToWord\bin\Release\net462

PAUSE