function I=KWR(I,n)
if n > 0
    I=KWR(I,n-1);
    Is=imresize(I,0.5);
    I=I*0+255;
    
    [d1,d2,~]=size(Is);
    
    % Lewy dolny róg
    I(end-d1+1:end,1:d2,:)=Is;
    
    % Prawy dolny róg
    I(end-d1+1:end,end-d2+1:end,:)=Is;
    
    % Œrodek
    I(1:d1,round(d2/2)+[1:d2],:)=Is;
end;

% Praca domowa

