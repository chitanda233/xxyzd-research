package com.byazt.mg;

import android.app.ActivityManager;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 170, 91})
public class sp {
    public static final c c = new tt();

    @com.byazt.zqa.c(c = {0, 1, 170, 180})
    private static class c {
        public long c(ActivityManager.MemoryInfo memoryInfo) {
            return 0L;
        }

        private c() {
        }
    }

    @com.byazt.zqa.c(c = {0, 1, 170, 904})
    private static class tt extends c {
        private tt() {
            super();
        }

        @Override // com.byazt.mg.sp.c
        public long c(ActivityManager.MemoryInfo memoryInfo) {
            return memoryInfo.totalMem;
        }
    }

    public static long c(ActivityManager.MemoryInfo memoryInfo) {
        return c.c(memoryInfo);
    }
}
