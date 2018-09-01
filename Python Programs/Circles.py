#Code by John Allison assets by Jason White, 20-10-2014
import os, sys, random, pygame, math
from pygame import *

pygame.init()

screen = pygame.display.set_mode((1024, 768), pygame.FULLSCREEN)
pygame.display.toggle_fullscreen()
pygame.display.set_caption('Circles')

screen.fill((random.randrange(0, 256), random.randrange(0, 256), random.randrange(0, 256)))

circle = False
square = False

while True:

    (mouseX, mouseY) = pygame.mouse.get_pos()
    
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
        elif event.type == pygame.MOUSEBUTTONDOWN:
            if pygame.mouse.get_pressed(button1):
                square = True
            elif pygame.mouse.get_pressed(button2):
                circle = True
        elif event.type == pygame.MOUSEBUTTONUP:
            circle = False
            square = False
        elif event.type == pygame.KEYDOWN:
            if event.key == pygame.K_SPACE:
                screen.fill((random.randrange(0, 256), random.randrange(0, 256), random.randrange(0, 256)))
            if event.key == pygame.K_ESCAPE:
                screen = pygame.display.set_mode((1024, 768))

    
    if square == True:
        colour = (random.randrange(0, 256), random.randrange(0, 256), random.randrange(0, 256)) # RGB
        size = random.randrange(0, 20) #Radius
        thickness = 0 #0 is filled
        pygame.draw.rect(screen, colour, (mouseX - (size / 2), mouseY - (size / 2), size, size), thickness)
        circle = False
        
    if circle == True:
        colour = (random.randrange(0, 256), random.randrange(0, 256), random.randrange(0, 256)) # RGB
        size = random.randrange(0, 200) #Radius
        thickness = random.randrange(0, size + 1) #0 is filled
        pygame.draw.circle(screen, colour, (mouseX, mouseY), size, thickness)
    
    pygame.display.flip()