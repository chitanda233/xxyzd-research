package com.byazt.nn;

import android.util.Pair;
import androidx.core.view.PointerIconCompat;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_GRAB, 13})
public class tt {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f1218a;
    public long c;
    public String i;
    public String n;
    public String sp;
    public long tt;
    public String uj;
    public String ve;
    public final List<Pair<String, String>> x = new ArrayList();

    public static long c(long j, long j2) {
        return j > 0 ? j : j2;
    }

    public long c() {
        return c(this.c, this.tt);
    }
}
