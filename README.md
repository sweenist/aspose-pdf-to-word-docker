# aspose-pdf-to-word-docker
Providing repro steps for Aspose regarding ticket 174403

# Steps to reproduce failure to convert certain PDFs to Word on docker in Windows

* Build the Release configuration for PdfToWordDocker.sln 
* From the docker folder:
   * run `build-docker.cmd`
   * run `run-docker-1909.cmd`
      * When the docker container loads, type `PdfToWordConsole.exe` and press <Enter>
      * Choose Option 1 and the pdf to word conversion will fail for the file **FileThatFailsIn1909.pdf**

I have also provided a 1803 build that works for this file. 
The failing pdf was created in BlueBeam but for the most part, pdfs created in bluebeam work when converting to word.
