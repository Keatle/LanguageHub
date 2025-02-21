import pandas as pd 

data = {
    "Name": ["Alice", "Bob","Charlie"],
    "Age": [25, 30 ,35],
    "City": ["New York", "Los Angeles", "Chicago"],
    "Salary": [35000, 45000, 29500]
}

df = pd.DataFrame(data)

print(df["Age"])