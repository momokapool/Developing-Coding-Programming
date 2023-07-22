from tkinter import *
import tkinter.scrolledtext as tkst

import video_library as lib

def set_text(text_area, content):
    text_area.delete("1.0", END)
    text_area.insert(1.0, content)

class CreateVideoList():
    def __init__(self, window):
        window.geometry("800x400")
        window.title("Check Videos")
        window.configure(background= "#333333")

    
