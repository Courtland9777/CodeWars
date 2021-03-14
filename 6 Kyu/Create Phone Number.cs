def create_phone_number(n):
    return f'({"".join(str(i) for i in n[:3])}) {"".join(str(i) for i in n[3:6])}-{"".join(str(i) for i in n[6:])}'