﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TP_DDS_MVC.Controllers;

namespace TP_DDS_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Add Proyecto",
                url: "proyecto/add",
                defaults: new { controller = "ProyectoFinanciamiento", action = "AddProyectoFinanciamiento" }
            );

            routes.MapRoute(
                name: "ListCompras",
                url: "compra",
                defaults: new { controller = "Compra", action = "ListCompras" }
            );

            routes.MapRoute(
                name: "Add Compra",
                url: "compra/add",
                defaults: new { controller = "Compra", action = "AddCompra" }
            );
                       
            routes.MapRoute(
                name: "Add Prestador de servicios",
                url: "compra/prestador-de-servicios/add",
                defaults: new { controller = "Compra", action = "AddPrestadorDeServicios" }
            );

            routes.MapRoute(
                name: "List Prestador de servicios",
                url: "compra/prestador-de-servicios",
                defaults: new { controller = "Compra", action = "ListPrestadorDeServicios" }
            );

            routes.MapRoute(
                name: "Add Medio de Pago",
                url: "compra/medio-de-pago/add",
                defaults: new { controller = "Compra", action = "AddMedioDePago" }
            );

            routes.MapRoute(
                name: "List Medio de Pago",
                url: "compra/medio-de-pago",
                defaults: new { controller = "Compra", action = "ListMedioDePago" }
            );

            routes.MapRoute(
                name: "Add Presupuesto",
                url: "compra/presupuesto/add",
                defaults: new { controller = "Compra", action = "AddPresupuesto" }
            );

            routes.MapRoute(
                name: "List presupuesto",
                url: "compra/presupuesto",
                defaults: new { controller = "Compra", action = "ListPresupuestos", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Detalle presupuesto",
                url: "compra/presupuesto/{id}",
                defaults: new { controller = "Compra", action = "DetallePresupuesto", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add Egreso",
                url: "compra/egreso/add",
                defaults: new { controller = "Compra", action = "AddEgreso" }
            );

            routes.MapRoute(
                name: "List ingresos",
                url: "ingreso",
                defaults: new { controller = "Ingreso", action = "ListIngresos" }
            );

            routes.MapRoute(
                name: "Add Ingreso",
                url: "ingreso/add",
                defaults: new { controller = "Ingreso", action = "AddIngreso" }
            );

            routes.MapRoute(
                name: "Menu Cargar Entidad",
                url: "entidad",
                defaults: new { controller = "Entidad", action = "MenuCargarEntidad" }
            );

            routes.MapRoute(
                name: "Add Entidad Juridica",
                url: "entidad/entidad-juridica/add",
                defaults: new { controller = "Entidad", action = "AddEntidadJuridica" }
            );

            routes.MapRoute(
                name: "Add Entidad Base",
                url: "entidad/entidad-base/add",
                defaults: new { controller = "Entidad", action = "AddEntidadBaseAJuridica" }
            );

            routes.MapRoute(
                name: "Logout",
                url: "usuario/logout",
                defaults: new { controller = "User", action = "Logout" }
            );

            routes.MapRoute(
                name: "Bandeja de mensajes",
                url: "usuario/mensajes",
                defaults: new { controller = "User", action = "BandejaDeMensajes" }
            );

            routes.MapRoute(
                 name: "Panel Admin",
                 url: "usuario/admin",
                 defaults: new { controller = "User", action = "PanelAdmin" }
             );

            routes.MapRoute(
                name: "Registar usuario",
                url: "usuario/registrar",
                defaults: new { controller = "User", action = "Register" }
            );

            routes.MapRoute(
                name: "Listar Usuarios",
                url: "usuario/listaUsuarios",
                defaults: new { controller = "User", action = "ListarUsuarios" }
            );

            routes.MapRoute(
                name: "Vinculador",
                url: "vinculador",
                defaults: new { controller = "Ingreso", action = "Vinculador" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
