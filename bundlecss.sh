#!/bin/bash

# Concatenate all CSS files in the Styles directory and the SmartEstimate bundle file
cat ./Styles/app.css ./Styles/site.css ./obj/Debug/net8.0/scopedcss/projectbundle/SmartEstimate.bundle.scp.css > ./Styles/bundle.css