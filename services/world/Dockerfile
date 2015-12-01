FROM aspnet5

COPY ./src /app
WORKDIR /app
RUN ["dnu","restore"]

# Open this port in the container
EXPOSE 5502
# Start application
ENTRYPOINT ["dnx","-p","./world", "web"]