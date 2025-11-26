# Event Management API

## תיאור הפרויקט
מערכת לניהול אירועים ונותני שירות עבור חברת הפקת אירועים.  
באמצעות המערכת ניתן לנהל אירועים, ספקים ושירותים, ולשייך ספקים לאירועים.

## ישויות
1. **אירוע (Event)**
2. **ספק (Vendor)**
3. **שירות (Service)**

---

## מיפוי Routes לאירועים (Event)

- **שליפת רשימת האירועים**  
`GET https://events.co.il/events`

- **שליפת אירוע לפי מזהה**  
`GET https://events.co.il/events/1`

- **הוספת אירוע**  
`POST https://events.co.il/events`

- **עדכון אירוע**  
`PUT https://events.co.il/events/1`

- **מחיקת אירוע**  
`DELETE https://events.co.il/events/1`

- **פעולה נוספת – שליפת הספקים של האירוע**  
`GET https://events.co.il/events/1/vendors`

---

## מיפוי Routes לספקים (Vendor)

- **שליפת רשימת הספקים**  
`GET https://events.co.il/vendors`

- **שליפת ספק לפי מזהה**  
`GET https://events.co.il/vendors/1`

- **הוספת ספק**  
`POST https://events.co.il/vendors`

- **עדכון ספק**  
`PUT https://events.co.il/vendors/1`

- **מחיקת ספק**  
`DELETE https://events.co.il/vendors/1`

- **פעולה נוספת – שליפת שירותים שספק מציע**  
`GET https://events.co.il/vendors/1/services`

---

## מיפוי Routes לשירותים (Service)

- **שליפת רשימת השירותים**  
`GET https://events.co.il/services`

- **שליפת שירות לפי מזהה**  
`GET https://events.co.il/services/1`

- **הוספת שירות**  
`POST https://events.co.il/services`

- **עדכון שירות**  
`PUT https://events.co.il/services/1`

- **מחיקת שירות**  
`DELETE https://events.co.il/services/1`

- **פעולה נוספת – שליפת ספקים המציעים שירות מסוים**  
`GET https://events.co.il/services/1/vendors`
