# dnvm use core
# dnu restore ./hello
# dnu restore ./world
# dnu restore ./helloworld

start dnx-watch --project ./hello/src/hello --dnx-args web
start dnx-watch --project ./world/src/world --dnx-args web
start dnx-watch --project ./helloworld/src/helloworld --dnx-args web