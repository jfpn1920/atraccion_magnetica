Imports System
Module atraccion_magnetica
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim objetos1(9) As String
        Dim polos1(9) As String
        Dim objetos2(9) As String
        Dim polos2(9) As String
        Dim distancias(9) As Double
        Dim fuerzas(9) As Double
        Dim resultados(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-------------------------------------------'
        '--|menu_principal_de_atraccion_magnetica|--'
        '-------------------------------------------'
        Do
            Console.WriteLine("menu principal de atraccion magnetica")
            Console.WriteLine("1) Registrar experimento")
            Console.WriteLine("2) Editar experimento")
            Console.WriteLine("3) Listar experimentos")
            Console.WriteLine("4) Buscar experimento")
            Console.WriteLine("5) Eliminar experimento")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '---------------------------'
                '--|registrar_experimento|--'
                '---------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas experimentos.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Objeto 1: ")
                        objetos1(cantidad) = Console.ReadLine()
                        Console.Write("Polo 1 (Norte/Sur): ")
                        polos1(cantidad) = Console.ReadLine()
                        Console.Write("Objeto 2: ")
                        objetos2(cantidad) = Console.ReadLine()
                        Console.Write("Polo 2 (Norte/Sur): ")
                        polos2(cantidad) = Console.ReadLine()
                        Console.Write("Distancia: ")
                        distancias(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Fuerza: ")
                        fuerzas(cantidad) = Convert.ToDouble(Console.ReadLine())
                        If polos1(cantidad).ToLower() = "norte" And polos2(cantidad).ToLower() = "sur" Then
                            resultados(cantidad) = "Atraccion"
                        ElseIf polos1(cantidad).ToLower() = "sur" And polos2(cantidad).ToLower() = "norte" Then
                            resultados(cantidad) = "Atraccion"
                        ElseIf polos1(cantidad).ToLower() = "norte" And polos2(cantidad).ToLower() = "norte" Then
                            resultados(cantidad) = "Repulsion"
                        ElseIf polos1(cantidad).ToLower() = "sur" And polos2(cantidad).ToLower() = "sur" Then
                            resultados(cantidad) = "Repulsion"
                        Else
                            resultados(cantidad) = "Sin efecto"
                        End If
                        estados(cantidad) = "Registrado"
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Experimento registrado correctamente.")
                    End If
                '------------------------'
                '--|editar_experimento|--'
                '------------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen experimentos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Objeto 1: " & objetos1(i) & " | Polo 1: " & polos1(i) & " | Objeto 2: " & objetos2(i) & " | Polo 2: " & polos2(i) & " | Distancia: " & distancias(i) & " | Fuerza: " & fuerzas(i) & " | Resultado: " & resultados(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del experimento a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo objeto 1: ")
                            objetos1(posicion) = Console.ReadLine()
                            Console.Write("Nuevo polo 1 (Norte/Sur): ")
                            polos1(posicion) = Console.ReadLine()
                            Console.Write("Nuevo objeto 2: ")
                            objetos2(posicion) = Console.ReadLine()
                            Console.Write("Nuevo polo 2 (Norte/Sur): ")
                            polos2(posicion) = Console.ReadLine()
                            Console.Write("Nueva distancia: ")
                            distancias(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva fuerza: ")
                            fuerzas(posicion) = Convert.ToDouble(Console.ReadLine())
                            If polos1(posicion).ToLower() = "norte" And polos2(posicion).ToLower() = "sur" Then
                                resultados(posicion) = "Atraccion"
                            ElseIf polos1(posicion).ToLower() = "sur" And polos2(posicion).ToLower() = "norte" Then
                                resultados(posicion) = "Atraccion"
                            ElseIf polos1(posicion).ToLower() = "norte" And polos2(posicion).ToLower() = "norte" Then
                                resultados(posicion) = "Repulsion"
                            ElseIf polos1(posicion).ToLower() = "sur" And polos2(posicion).ToLower() = "sur" Then
                                resultados(posicion) = "Repulsion"
                            Else
                                resultados(posicion) = "Sin efecto"
                            End If
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Experimento actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------'
                '--|listar_experimentos|--'
                '-------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen experimentos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Objeto 1: " & objetos1(i) & " | Polo 1: " & polos1(i) & " | Objeto 2: " & objetos2(i) & " | Polo 2: " & polos2(i) & " | Distancia: " & distancias(i) & " | Fuerza: " & fuerzas(i) & " | Resultado: " & resultados(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '------------------------'
                '--|buscar_experimento|--'
                '------------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen experimentos registrados.")
                    Else
                        Console.Write("Ingrese el ID del experimento a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Objeto 1: " & objetos1(posicion) & " | Polo 1: " & polos1(posicion) & " | Objeto 2: " & objetos2(posicion) & " | Polo 2: " & polos2(posicion) & " | Distancia: " & distancias(posicion) & " | Fuerza: " & fuerzas(posicion) & " | Resultado: " & resultados(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------------'
                '--|eliminar_experimento|--'
                '--------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen experimentos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Objeto 1: " & objetos1(i) & " | Polo 1: " & polos1(i) & " | Objeto 2: " & objetos2(i) & " | Polo 2: " & polos2(i) & " | Distancia: " & distancias(i) & " | Fuerza: " & fuerzas(i) & " | Resultado: " & resultados(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del experimento a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                objetos1(i) = objetos1(i + 1)
                                polos1(i) = polos1(i + 1)
                                objetos2(i) = objetos2(i + 1)
                                polos2(i) = polos2(i + 1)
                                distancias(i) = distancias(i + 1)
                                fuerzas(i) = fuerzas(i + 1)
                                resultados(i) = resultados(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Experimento eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen experimentos registrados.")
                    Else
                        Dim atracciones As Integer = 0
                        Dim repulsiones As Integer = 0
                        Dim sinEfecto As Integer = 0
                        Dim fuerzaTotal As Double = 0
                        Dim fuerzaMayor As Double = fuerzas(0)
                        Dim fuerzaMenor As Double = fuerzas(0)
                        Dim polosNorte As Integer = 0
                        Dim polosSur As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            fuerzaTotal += fuerzas(i)
                            If fuerzas(i) > fuerzaMayor Then
                                fuerzaMayor = fuerzas(i)
                            End If
                            If fuerzas(i) < fuerzaMenor Then
                                fuerzaMenor = fuerzas(i)
                            End If
                            Select Case resultados(i).ToLower()
                                Case "atraccion"
                                    atracciones += 1
                                Case "repulsion"
                                    repulsiones += 1
                                Case "sin efecto"
                                    sinEfecto += 1
                            End Select
                            If polos1(i).ToLower() = "norte" Then
                                polosNorte += 1
                            End If
                            If polos1(i).ToLower() = "sur" Then
                                polosSur += 1
                            End If
                            If polos2(i).ToLower() = "norte" Then
                                polosNorte += 1
                            End If
                            If polos2(i).ToLower() = "sur" Then
                                polosSur += 1
                            End If
                        Next
                        Dim fuerzaPromedio As Double = fuerzaTotal / cantidad
                        Console.WriteLine("Experimentos: " & cantidad & " | Atracciones: " & atracciones & " | Repulsiones: " & repulsiones & " | Sin efecto: " & sinEfecto & " | Fuerza total: " & fuerzaTotal & " | Fuerza promedio: " & fuerzaPromedio & " | Mayor fuerza: " & fuerzaMayor & " | Menor fuerza: " & fuerzaMenor & " | Polos Norte: " & polosNorte & " | Polos Sur: " & polosSur)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Atraccion Magnetica.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module