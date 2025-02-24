import pandas as pd 

a = {
    "Name": ["Alice", "Bob","Charlie"],
    "Age": [ 25, 30, 35],
    "City": ["New York", "Los Angeles" , "Chicago"],
    "Salary": [35000, 45000, 29500]
}

c = pd.DataFrame(a)
c["Phone_"] = ["076417345", "0112223333", "0121113322"]
c.loc[0,"Age"] = 26

print(c[a["Age"]] >= 20)
