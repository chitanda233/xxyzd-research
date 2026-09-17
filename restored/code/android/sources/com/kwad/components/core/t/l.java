package com.kwad.components.core.t;

import android.graphics.Rect;
import android.view.View;
import android.view.ViewTreeObserver;
import android.view.Window;
import java.util.WeakHashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class l {
    private static final WeakHashMap<a, ViewTreeObserver.OnGlobalLayoutListener> alP = new WeakHashMap<>();

    public interface a {
        void bp(int i);

        void vo();
    }

    public static void a(Window window, final a aVar) {
        WeakHashMap<a, ViewTreeObserver.OnGlobalLayoutListener> weakHashMap = alP;
        if (weakHashMap.get(aVar) != null) {
            return;
        }
        final View decorView = window.getDecorView();
        ViewTreeObserver.OnGlobalLayoutListener onGlobalLayoutListener = new ViewTreeObserver.OnGlobalLayoutListener() { // from class: com.kwad.components.core.t.l.1
            private int WH;

            @Override // android.view.ViewTreeObserver.OnGlobalLayoutListener
            public final void onGlobalLayout() {
                Rect rect = new Rect();
                decorView.getWindowVisibleDisplayFrame(rect);
                int iHeight = rect.height();
                int i = this.WH;
                if (i == 0) {
                    this.WH = iHeight;
                    return;
                }
                if (i == iHeight) {
                    return;
                }
                int height = decorView.getHeight() / 4;
                int i2 = this.WH;
                if (i2 - iHeight > height) {
                    aVar.bp(i2 - iHeight);
                    this.WH = iHeight;
                } else if (iHeight - i2 > height) {
                    aVar.vo();
                    this.WH = iHeight;
                }
            }
        };
        decorView.getViewTreeObserver().addOnGlobalLayoutListener(onGlobalLayoutListener);
        weakHashMap.put(aVar, onGlobalLayoutListener);
    }

    public static void b(Window window, a aVar) {
        window.getDecorView().getViewTreeObserver().removeOnGlobalLayoutListener(alP.remove(aVar));
    }
}
