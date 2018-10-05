import smtplib

# gmail_user = 'just.try2share@gmail.com'  
# gmail_password = 'NGkAASdT4mMNG3w!'

# gmail_user = 'abdo14hashem15@gmail.com'  
# gmail_password = 'ihtpspri'

gmail_user = 'abdo.hashem98@mail.ru'  
gmail_password = 'fkKGjQw6EGRMmfz'


sent_from = gmail_user  
to = ['ar1813@fayoum.edu.eg']  
subject = 'OMG Super Important Message'  
body = "Hey, what's up?\n\n- You"

email_text = """\  
 
Subject: %s

%s
""" % (subject, body)

# server = smtplib.SMTP_SSL('smtp.gmail.com', 465)
server = smtplib.SMTP_SSL('smtp.mail.ru', 465 )

server.ehlo()
server.login(gmail_user, gmail_password)
server.sendmail(sent_from, to, email_text)
server.close()

print ('Email sent!')