using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WEXCorporatePaymentsProduct
{
    public static class PurchaseTransactionIO
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TransactionHistory", "PurchaseTransactionHistory.txt");

        public static string writePurchaseTransaction(PurchaseTransaction content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine(content.ToString());
                }
                return $"Successfully stored {content.description} with ID: {content.id}";
            }
            catch (Exception ex)
            {
                return $"Error writing to file: {ex.Message}";
            }
        }

        public static List<PurchaseTransaction> readAllPurchaseTransactions()
        {
            var transactions = new List<PurchaseTransaction>();

            try
            {
                if (!File.Exists(FilePath))
                    throw new Exception("Purchase Transaction file not found.");

                foreach (var line in File.ReadAllLines(FilePath))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    try
                    {
                        PurchaseTransaction transaction = JsonSerializer.Deserialize<PurchaseTransaction>(line);
                        if (transaction != null)
                            transactions.Add(transaction);
                    }
                    catch (JsonException)
                    {
                        Console.WriteLine($"Invalid JSON skipped: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            return transactions;
        }
    }
}
