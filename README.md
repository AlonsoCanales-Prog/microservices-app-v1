# 🌿 Acuaponía - Sistema Inteligente de Cultivo Integrado

Acuaponía es un sistema inteligente que automatiza y optimiza el cultivo de **plantas y peces** utilizando sensores, microcontroladores y procesamiento de datos en tiempo real. El sistema está basado en una **arquitectura de microservicios escalable y resiliente**, siguiendo los principios de diseño **SOLID**, **CQRS** y las mejores prácticas de la ingeniería de software moderna.

---

## ⚙️ Tecnologías Utilizadas

- **Lenguajes:** Python, C#, C, JavaScript, TypeScript  
- **Microcontroladores:** ESP32  
- **Backend y Lógica de Negocio:** C#, Python  
- **Frontend:** JavaScript / TypeScript  
- **Base de Datos:** MySQL  
- **Contenerización:** Docker  
- **Orquestación:** Kubernetes (K8s)  
- **CI/CD:** GitLab Pipelines  
- **Servidor:** DigitalOcean  
- **Control de Versiones:** GitLab  
- **Gestión de Proyecto:** Jira  

---

## 🧱 Arquitectura de Microservicios

### ✅ División en Servicios Independientes

Cada microservicio cumple con una responsabilidad única y está desacoplado del resto. Ejemplos:

- `SensorService`: Recolecta datos de los sensores del agua y ambiente.
- `FishMonitorService`: Gestiona la salud y alimentación de los peces.
- `PlantControlService`: Monitorea y ajusta el crecimiento de las plantas.
- `UserService`: Control de usuarios, autenticación y roles.
- `NotificationService`: Envío de alertas por condiciones críticas.

Cada servicio tiene una **interfaz bien definida** (API REST) y puede evolucionar de forma independiente.

![Servicios Independientes](img/ser1.png)

---

## 🐳 Contenerización con Docker

Cada microservicio ha sido **empaquetado en su propio contenedor Docker**, incluyendo su código fuente, dependencias y configuración. Esto asegura portabilidad y consistencia en todos los entornos.

![Dockerizacion](img/dock.png)

---

## ☸️ Orquestación con Kubernetes

Los contenedores Docker están orquestados mediante **Kubernetes**, lo cual permite:

- Despliegue automatizado y balanceo de carga.
- Escalado horizontal y vertical según demanda.
- Alta disponibilidad y autorecuperación ante fallos.

---

## 🔄 Comunicación entre Microservicios

- Se utilizan **APIs RESTful** para la comunicación síncrona.
- Se implementa mensajería asíncrona con colas de eventos para tareas desacopladas.
- Los contratos entre microservicios se definen mediante **OpenAPI/Swagger**.

---

## 🔍 Monitorización y Observabilidad

- Se ha integrado **Istio** como service mesh para visibilidad de tráfico, control de políticas y seguridad.
- Se recopilan logs y métricas con herramientas como **Grafana**, **Prometheus** y **Azure Monitor** para detectar anomalías y optimizar rendimiento.

![Monitorizacion](img/mon1.png)
![Monitorizacion](img/mon2.png)
![Monitorizacion](img/mon3.png)

---

## 🚀 CI/CD Automatizado

- El proyecto se despliega automáticamente usando **pipelines de GitLab CI/CD**.
- El servidor en **DigitalOcean** está configurado para hacer **auto-deploy** al detectar cambios en la rama principal.
- Se incluyen etapas de **build, test, deploy y rollback automático** ante fallos.

![Automatizacion](img/auto.png)

---

## 🛡️ Seguridad

- **Autenticación y autorización** implementadas a nivel de API.
- Comunicaciones entre microservicios cifradas mediante **HTTPS y JWT**.
- Validación de entradas y sanitización para prevenir ataques comunes.

![Seguridad](img/cqrs1.png)
![Seguridad](img/cqrs2.png)

---

## 🌪️ Ingeniería del Caos

Implementamos **Chaos Engineering** para validar la resiliencia del sistema bajo condiciones adversas. Se simulan:

- Caídas de servicios individuales.
- Latencia en la red.
- Sobrecarga de recursos.

Esto nos permite fortalecer el sistema contra fallos reales y garantizar una experiencia robusta.

---

## 📈 Diseño Escalable y Resiliente

- Los servicios pueden escalar dinámicamente según la carga, utilizando Kubernetes HPA.
- La arquitectura CQRS permite separar comandos y consultas, optimizando rendimiento.
- Se siguen **principios SOLID** para garantizar mantenibilidad y evolución del código.

![Escalabilidad](img/dis.png)

---

## 🧪 Cómo Desplegar el Proyecto

### Requisitos

- Docker
- Kubernetes (Minikube o clúster real)
- GitLab con runner configurado
- DigitalOcean (opcional, si se quiere replicar despliegue en la nube)

### Pasos

1. Clona el repositorio:
   ```bash
   https://github.com/AlonsoCanales-Prog/microservices-app-v1.git
   cd aquaponia

### Levanta servicios con Docker

- docker-compose up --build

### Para usar Kubernetes

- kubectl apply -f k8s/
