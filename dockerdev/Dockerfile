FROM docker:latest

ENV DOCKER_TLS_VERIFY="1"
ENV DOCKER_HOST="tcp://192.168.99.100:2376"
ENV DOCKER_CERT_PATH="/home/certs"
ENV DOCKER_MACHINE_NAME="dev"

RUN mkdir /home/certs
COPY certs /home/certs

ENTRYPOINT ["docker-entrypoint.sh"]
CMD ["sh"]