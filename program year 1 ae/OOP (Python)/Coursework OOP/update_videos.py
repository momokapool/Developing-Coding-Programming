from tkinter import *
import tkinter.messagebox as messagebox
import tkinter.scrolledtext as tkst

import video_library as lib

def set_text(text_area, content):
    text_area.delete("1.0", END)
    text_area.insert(1.0, content)



class UpdateVideo:
    def __init__(self, window):
        window.geometry("1000x600")
        window.title("Check Videos")
        window.configure(background= "#333333")

        enter_new_lbl = Label(window, text="Enter video number", background="#458B74")
        enter_new_lbl.grid(row=0, column=0, padx=24, pady=24)

        self.number_txt = Entry(window, width=30)
        self.number_txt.grid(row=0, column=1, padx=24, pady=24)

        enter_new_lbl = Label(window, text="Enter Playlist's new rate", background="#458B74")
        enter_new_lbl.grid(row=1, column=0, padx=24, pady=24)

        self.new_rate_txt = Entry(window, width=30)
        self.new_rate_txt.grid(row=1, column=1, padx=24, pady=24)

        update_new_video_btn = Button(window, text="Update video", background="#458B74", command=self.update_video)
        update_new_video_btn.grid(row=2, column=0, padx=24, pady=24)


    def update_video(self):
        video_number = self.number_txt.get()
        rating = self.new_rate_txt.get()
        video_name = lib.get_name(video_number)
        if not video_number.isdigit():
            messagebox.showerror("Invalid video number")
            return
        if video_name is None:
            messagebox.showerror("Not found!")
            return
        if not rating.isdigit():
            messagebox.showerror("Invalid rating!")
            return
        lib.update_rating(video_number, rating)







    





    

    

        
        