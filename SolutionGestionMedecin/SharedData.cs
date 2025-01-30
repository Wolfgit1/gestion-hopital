using System.Data;
using System;

public static class SharedData
{
    public static DataTable PatientTable = new DataTable();

    static SharedData()
    {
        // Ajoutez les colonnes à la DataTable
        PatientTable.Columns.Add("Identifiant", typeof(int));
        PatientTable.Columns.Add("Nom", typeof(string));
        PatientTable.Columns.Add("Prénom", typeof(string));
        PatientTable.Columns.Add("Adresse", typeof(string));
        PatientTable.Columns.Add("Téléphone", typeof(string));
        PatientTable.Columns.Add("Courriel", typeof(string));
        PatientTable.Columns.Add("Date de Naissance", typeof(DateTime));
    }
}
