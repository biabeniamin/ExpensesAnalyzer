#generated automatically
from dataclasses import dataclass

@dataclass_json
@dataclass
class Transaction:
	transactionId : int
	accountId : int
	categoryId : int
	name : str
	value : str
	creationTime : str
	

