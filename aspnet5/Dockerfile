FROM microsoft/aspnet:1.0.0-rc1-final-coreclr

COPY ./src /app
WORKDIR /app
RUN ["dnu","restore"]
