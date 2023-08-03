from tkinter import *
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

        self.new_txt = Entry(window, width=30)
        self.new_txt.grid(row=1, column=1, padx=24, pady=24)

        update_new_video_btn = Button(window, text="Update video", background="#458B74", command=self.update)
        update_new_video_btn.grid(row=2, column=0, padx=24, pady=24)

        list_videos_btn = Button(window, text="List All Videos", command=self.list_videos_clicked,  background="#458B74")
        list_videos_btn.grid(row=0, column=2, padx=10, pady=10)

        self.list_txt = tkst.ScrolledText(window, width=48, height=12, wrap="none")
        self.list_txt.grid(row=1, column=2, columnspan=3, sticky="W", padx=10, pady=10)


    def list_videos_clicked(self):
        video_list = lib.list_all()
        set_text(self.list_txt, video_list)

    def update(self):
        pass


    





    

    

        
        