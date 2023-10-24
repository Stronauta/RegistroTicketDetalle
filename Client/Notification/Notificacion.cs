using Radzen;
using System.Runtime.CompilerServices;

namespace RegistroTicketsDetalle.Client.Notification
{
	public static class Notificacion
	{
		public static void Notificar(this NotificationService notificar, string Title, string Message, NotificationSeverity severity = NotificationSeverity.Info)
		{
			if(notificar == null) throw new System.ArgumentNullException(nameof(notificar));

			var mensajeNotificacion = new NotificationMessage
			{
				Severity = severity,
				Summary = Title,
				Detail = Message,
				Duration = 3_000
			};
			notificar.Notify(mensajeNotificacion);
		}
	}
}

