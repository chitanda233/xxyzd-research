package com.byazt.nl;

import android.util.Pair;
import android.view.MotionEvent;
import android.view.View;

/* JADX INFO: loaded from: classes2.dex */
public interface ve {

    public interface c {
        Pair<Boolean, Boolean> c(View view, MotionEvent motionEvent);
    }

    void setTag(int i, Object obj);

    void setTouchEventListener(c cVar);
}
