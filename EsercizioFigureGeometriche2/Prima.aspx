<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prima.aspx.cs" Inherits="EsercizioFigureGeometriche2.Prima" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <center><table width="90%" style="border:2px solid black">
        <tr>
            <td colspan="3">
           <center>     <h2><strong>Calcolo area e perimetro delle figure geometriche!</strong></h2></center>
            </td>
        </tr>
        

        <tr runat="server" id="trinizio">
            <td style="margin-top:5px;margin-bottom:5px" colspan="3">
               <center><asp:Button runat="server" ID="BottoneTriangolo" OnClick="BottoneTriangolo_Click" Text="Triangolo" style="margin-top:5px;margin-bottom:5px"  /></center>
            </td>
            </tr>
        <tr  runat="server" id="trinizio2">
            <td style="margin-top:5px;margin-bottom:5px" colspan="3">
             <center>  <asp:Button runat="server" ID="BottoneCerchio" OnClick="BottoneCerchio_Click" Text="Cerchio" style="margin-top:5px;margin-bottom:5px" /></center>
            </td>
            </tr>
        <tr  runat="server" id="trinizio3">
            <td style="margin-top:5px;margin-bottom:5px" colspan="3">
              <center> <asp:Button runat="server" ID="BottoneRettangolo" OnClick="BottoneRettangolo_Click" Text="Rettangolo" style="margin-top:5px;margin-bottom:5px" /></br> Quadrato se Lato=Altezza</center>
            </td>
        </tr>
        
        <tr runat="server" id="tr0" visible="false">
            <td runat="server" id="td1" visible="false">
              <strong>Lato:</strong>  <asp:TextBox runat="server" ID="TextLato"></asp:TextBox>
            </td>
            <td runat="server" id="td2" visible="false">
                <strong>Altezza:</strong> <asp:TextBox runat="server" ID="TextAltezza"></asp:TextBox>
            </td>
            <td runat="server" id="td3" visible="false">
                 <strong>Raggio:</strong><asp:TextBox runat="server" ID="TextRaggio"></asp:TextBox>
            </td>
        </tr>
        
        <tr runat="server" id="trcalcolo" >
            <td colspan="3">
                 <center> <asp:Button runat="server" ID="BottoneCalcolo" OnClick="BottoneCalcolo_Click" Text="Calcola" style="margin-top:5px;margin-bottom:5px" /> </center>
            </td>
        </tr>
        <tr runat="server" id="tr1" visible="false">
            <td colspan="3">
             <strong>Area Triangolo:</strong>   <asp:Label runat="server" ID="TextAreaT" Text="ok" ></asp:Label></br>
               <strong>Perimetro Triangolo:</strong>  <asp:Label runat="server" ID="TextPerimetroT" Text="ok" ></asp:Label>

            </td>
        </tr>
       
        <tr runat="server" id="tr2" visible="false">
            <td colspan="3">
              <strong>Area Cerchio:</strong>   <asp:Label runat="server" ID="TextAreaC" Text="ok" ></asp:Label> </br>
               <strong>Perimetro Cerchio:</strong>    <asp:Label runat="server" ID="TextPerimetroC" Text="ok" ></asp:Label>

            </td>
        </tr>
        <tr runat="server" id="tr3" visible="false">
            <td colspan="3">
             <strong>Area Rettangolo:</strong>    <asp:Label runat="server" ID="TextAreaR" Text="ok" ></asp:Label></br>
                <strong>Perimetro Rettangolo:</strong>   <asp:Label runat="server" ID="TextPerimetroR" Text="ok"></asp:Label>

            </td>
        </tr>
        <tr runat="server" id="tr4" visible="false">
            <td colspan="3">
             <strong>Area Quadrato:</strong>    <asp:Label runat="server" ID="TextAreaQ" Text="ok" ></asp:Label></br>
                <strong>Perimetro Quadrato:</strong>   <asp:Label runat="server" ID="TextPerimetroQ" Text="ok" ></asp:Label>

            </td>
        </tr>
    </table></center>
    <asp:Label runat="server" ID="test1" Text="zzz" Visible="false" ></asp:Label></br>
    <asp:Label runat="server" ID="test2" Text="zzz"  Visible="false"></asp:Label></br>
    <asp:Label runat="server" ID="test3" Text="zzz"  Visible="false"></asp:Label></br>
    <asp:Label runat="server" ID="test4" Text="zzz" Visible="false" ></asp:Label>
</asp:Content>
