package com.byazt.w;

import androidx.core.view.PointerIconCompat;
import java.util.LinkedHashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_TOP_LEFT_DIAGONAL_DOUBLE_ARROW, 71})
public class x<K, T> extends LinkedHashMap<K, T> {
    public int c;

    public x() {
        this(4, 4);
    }

    public x(int i, int i2) {
        this(i, i2, true);
    }

    public x(int i, int i2, boolean z) {
        super(i, 0.75f, z);
        c(i2);
    }

    public void c(int i) {
        this.c = i;
    }

    @Override // java.util.LinkedHashMap
    public boolean removeEldestEntry(Map.Entry<K, T> entry) {
        return size() > this.c;
    }
}
