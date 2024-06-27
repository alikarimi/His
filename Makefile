test:
	echo $(name)

add-migration:
	dotnet ef migrations add $(name) -s ./His.Presentation.Web/His.Presentation.Web.csproj -p ./His.DataAccess/His.DataAccess.csproj 