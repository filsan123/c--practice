(Assignment Part 2)



---

## 📋 Farqiga u dhexeeya habkii aan qadanay  iyo Habka Cusub 



| Nooca Shaqada (Function) 
 Habka Caadiga ah ee aaan kuqadanay (Chapter 4) 

  Habka aan u isticmalay 
   Farqiga iyo Faa'iidada aad ka Helayso
 
 **1. Write File** Wuxuu adeegsadaa `File.CreateText()`, 
 kaas oo**tirtiraya** xogtii hore mar kasta oo la qorayo mid cusub (Overwrites). 
  Waxaa la adeegsaday `File.AppendText()`.  **Faa'iidada:** Xogtii hore way nabad gashay, tan cusubna waxaa lagu darayaa safka hoose (New line), taas oo ka hortagaysa in xog la lunsado. 
| **2. Read File** Badanaa wuxuu isticmaalaa habab fudud oo xogta hal mar soo wada bandhigaya ama aan nidaamsanayn. 
Waxaa la adeegsaday `StreamReader` oo lala kaashaday `while (!inputFile.EndOfStream)` iyo `ReadLine()`. 
 **Faa'iidada:** Faylka ayay xariiq-xariiq u akhrinaysaa, waxayna si nadiif ah ugu soo bandhigaysaa sanduuqa **ListBox** (`lstOutput`). 
| **3. Delete Item**  Cutubyada bilowga ah lama socodsiiyo, ama qofka ayaa si gacanta ah u tirtiraya faylka oo dhan. 
 Marka la doortayo xubin ka tirsan ListBox-ka, barnaamijku wuxuu ka tirtirayaa halkaas, kadibna wuxuu dib u qorayaa xogtii hartay. 
  **Faa'iidada:** Waxay si toos ah isugu xidhaysaa (Synchronize) xusuusta shaashadda GUI-ga iyo faylka ku jira kumbuyuutarka. 
| **4. Delete File**  Tirtirid toos ah oo aan lahayn wax digniin ah ama hubin ah (`File.Delete`).  Waxaa la geliyay hubin (`File.Exists()`) iyo sanduuq xaqiijin ah (`MessageBox.Show` oo leh Yes/No).  **Faa'iidada:** Waxay ka hortagtaa in faylka si shil ah loo tirtiro, waxayna siisaa barnaamijka ammaan iyo xirfad dheeraad ah (Better UX).

---

## 🛠️ Faahfaahinta Kontaroolada Foomka 
* **`txtInput` (TextBox):** Sanduuqa lagu qoro qoraalka ama magaca aad rabto inaad keydiso.
* **`lstOutput` (ListBox):** Sanduuqa weyn ee lagu soo bandhigo magacyada iyo xogta laga soo akhriyay faylka.
* **`btnWrite`:** Badhanka keydinta (Appends text safely).
* **`btnRead`:** Badhanka akhrinta xogta iyo gelinta ListBox-ka.
* **`btnDeleteItem`:** Badhanka tirtiraya xubinta la doortay oo keliya.
* **`btnDeleteFile`:** Badhanka tirtiraya faylka oo dhan marka la xaqiijiyo.

---

## 💻 Qaybaha Koodka Muhiimka ah (Code Implementation)

### 1. Habka Qorista Cusub (`btnWrite`)
```csharp
private void btnWrite_Click(object sender, EventArgs e)
{
    try
    {
        if (!string.IsNullOrWhiteSpace(txtInput.Text))
        {
            // Waxay ku darsaneysaa faylka iyadoon tirtirin kii hore
            StreamWriter outputFile = File.AppendText(FILE_NAME);
            outputFile.WriteLine(txtInput.Text);
            outputFile.Close();

            MessageBox.Show("Xogta si guul leh ayaa loo qoray!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtInput.Clear();
            txtInput.Focus();
        }
        else
        {
            MessageBox.Show("Fadlan geli qoraal sanduuqa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
private void btnRead_Click(object sender, EventArgs e)
{
    try
    {
        lstOutput.Items.Clear();

        if (File.Exists(FILE_NAME))
        {
            StreamReader inputFile = File.OpenText(FILE_NAME);

            // Akhrinta xariiq-xariiq ilaa laga gaaro dhammaadka faylka
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                lstOutput.Items.Add(line);
            }

            inputFile.Close();
        }
        else
        {
            MessageBox.Show("Faylku ma jiro ama weli lama abuurin!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}