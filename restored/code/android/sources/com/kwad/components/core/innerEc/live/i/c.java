package com.kwad.components.core.innerEc.live.i;

import android.content.Context;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.bd;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static final CharSequence XS = "navigationBarBackground";
    public static final Float XT = Float.valueOf(263.0f);
    public static final Float XU = Float.valueOf(201.5f);
    private static int XV = ai.VJ();
    private static int XW;
    private static int XX;

    public static int ax(Context context) {
        return com.kwad.sdk.c.a.a.a(context, 20.0f);
    }

    public static int b(Context context, boolean z) {
        if (XW == 0) {
            XW = com.kwad.sdk.c.a.a.bD(context).y;
        }
        return XW;
    }

    public static void aS(int i) {
        if (i == XV) {
            return;
        }
        XV = i;
        ai.fM(i);
    }

    public static int sW() {
        return XV;
    }

    public static int c(Context context, boolean z) {
        return com.kwad.sdk.c.a.a.a(context, XT.floatValue());
    }

    public static int ay(Context context) {
        if (XX == 0) {
            XX = com.kwad.sdk.c.a.a.bB(context).y;
            int identifier = context.getResources().getIdentifier("navigation_bar_height", "dimen", "android");
            if (identifier > 0) {
                XX = context.getResources().getDimensionPixelSize(identifier);
            }
        }
        return XX;
    }

    public static boolean a(Context context, Window window, int[] iArr) {
        if (bd.Wl()) {
            return com.kwad.sdk.c.a.a.bB(context).y > 0;
        }
        ViewGroup viewGroup = (ViewGroup) window.getDecorView();
        for (int i = 0; i < viewGroup.getChildCount(); i++) {
            View childAt = viewGroup.getChildAt(i);
            if (childAt != null && childAt.getId() != -1) {
                if (TextUtils.equals(XS, context.getResources().getResourceEntryName(childAt.getId())) && childAt.getVisibility() == 0) {
                    iArr[0] = childAt.getHeight();
                    return true;
                }
            }
        }
        return false;
    }
}
