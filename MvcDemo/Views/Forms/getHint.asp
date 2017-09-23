<%
    response.expire=-1
    dim a(30)
    a(1)="Ana"
    a(2)="Bernardo"
    a(3)="Clara"
    a(4)="Diana"
    a(5)="Eva"
    a(6)="Fiona"
    a(7)="Gabriela"
    
    'recibir el parémetro que me enviaron desde el HTML
    q=ucase(request.querystring("q"))

    'buscar las sugerencias siempre que la longitud de q>0
    if len(q)>0 then
        hint=""
        for i=1 to 7
            if q=ucase(mid(a(i),1,len(q))) then
                if hint="" then
                    hint=a(i)
                else
                    hint=hint & ", " & a(i)
                end if
            end if
        next
    end if

    Retornar "sin sugrencia" si no se encuentran coincidencias
    
    'o retornar el valor encontrado
    if hint="" then
        response.write("sin sugerencias")
    else
        response.write(hint)
    end if
%>