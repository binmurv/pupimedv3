/*
 * 
[] network programming
[] patient searching  sa patient logs
[] display balance sa meds
[] fifo
[] consumed status
[] per piece with date
[] edit delete trans'
[] ConnString to ConnInfo
[ok] Stocks Query 

[] Notifs - Nauuna sa mainform (fix) -- use threads i guess
[] Real time notifs 



[ok] Receive Items- update duplicate constraints for Items

[ok] Notifs - pag naclose na lahat, nagsesend to back yung main form (fix)
[ok] Welcome screen bg 
[ok] ITEMS - Add Dosage & Form On Combobox
[ok] by piece computation (sa distrib & logs) 
[ok] Double click view
[ok] Filter Advanced Options (DYNAMIC SEARCHING)
[ok] Patient module

[ok] cbUOM - connect to database :) 

[ok] Receive Items- TABS
[ok]  Item Distrib - TABS
[ok] Item - Update list of manufacturers after add
[ok] Item Distrib - update list of branch after add
[ok] Item Distrib - NO 0 VALUE FOR QTY 

[ok] Receive Items- update query 
[ok] Receive Items- Disable Edit and delete buttons if listview is empty

[ok] Receive Items- must not be able to add Qty of 0, and piece per box of 0
[ok] Receive Items- batch code is only for meds
[ok] Receive Items- Clear Fields after add, edit
[ok] Receive Items- txtPQty is only for UOM=box

[ok] Receive Items- Fix listView (add,edit,delete)
[ok] Receive Items- Update list of suppliers after add

[ok] Piece per Box 
[ok] Item Distribution Form - Update Balance After Saving 
[ok] Item Distribution Form - No Duplicate Branches 
[ok] Update form for medicine (dosage & formulation)
*patient logs form 
** Patient name Combo box and plus icon
** Patient type
** Dept/College (depends to the patient typee)
***combo box and plus icon
** complaints
** treatment
** meds given
** quantity

OPTIONAL:
[] remove item library, change with maintenance tab
[]* items (meds, supps, eq)
[]* branches-uc
[]* supplier-uc
[]* manufacturer-uc
[]* branches-form
[]* supplier-form
[]* manufacturer-form


[under observation] Mali pa yung lumalabas sa item inventory, lahat ng narereceive eh nagiging biogesic lahat. kaya mali yung sa item inventory at received items sa radio button. Dahil dito na mamali yung availabe sa form add item to distribute. 

------------------------------------------------------------
DATABASE (3NF req)
[be-fe] **backend-frontend
[-] Items - Name(plus dosage&formulation) must be unique
[-] Items (meds) - add dosage & formulation
[-] Receive(Meds) -  add Batch Code
[-] Receive(Meds) - add Piece per Box 
[-] Logs - Add Patient Additional info (College, Dept)
[-] Item -> Remove Campus Detail (?) //Di ko nagets si sir
[-] Medicine - Batch Code (receive)
[-] Stock Card -> Per Receipt, display DateReceived, BeginningBal, EndBal 
[ ] Address- unique .... 
	- if may kamukha dapat same address code na


[ok-] Contact -> TEXT
[ok-] Branch - Name must be unique 
[ok-] Manufacturer - Name must be unique
[ok-] Supplier - Name must be unique
[ok-] Receive(header) - add Delivery Receipt
[ok-ok] Manufacturer, Branch - add Address


++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-----------DONE---DONE---DONE-----------------
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
<<<SYSTEM>>>
[ok] Smart Counter - Default number is 1, if none found.
[ok] Supplier tab
[ok] Supplier Form
[n/a] DATE in notif tab (date kung kelan nag appear yung notif)
VALIDATION:
[ok] *min/max
[ok] *qty
[ok] *piece per box
[errormsg] Di dapat makapag input ng number na mas mataas sa available

<<<Database>>>
[ok-ok] tblDistributor -> rename as suppplier
*/