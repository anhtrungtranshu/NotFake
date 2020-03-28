FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["NotFake/NotFake.csproj", "NotFake/"]
COPY ["Service/Service.csproj", "Service/"]
COPY ["DAO/DAO.csproj", "DAO/"]
RUN dotnet restore "NotFake/NotFake.csproj"
COPY . .
WORKDIR "/src/NotFake"
# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh
RUN dotnet build "NotFake.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "NotFake.csproj" -c Release -o /app
RUN dotnet ef database update

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NotFake.dll"]
