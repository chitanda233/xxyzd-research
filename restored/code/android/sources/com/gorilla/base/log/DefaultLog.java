package com.gorilla.base.log;

import android.util.Log;

/* JADX INFO: loaded from: classes3.dex */
class DefaultLog implements ILogger {
    private boolean enable = true;

    @Override // com.gorilla.base.log.ILogger
    public void setEnable(boolean z) {
        this.enable = z;
    }

    @Override // com.gorilla.base.log.ILogger
    public void log(String str, String str2) {
        if (this.enable) {
            Log.d("[Gorilla]", String.format("%s %s", str, str2));
        }
    }

    @Override // com.gorilla.base.log.ILogger
    public void warning(String str, String str2) {
        if (this.enable) {
            Log.w("[Gorilla] ", String.format("%s %s", str, str2));
        }
    }

    @Override // com.gorilla.base.log.ILogger
    public void error(String str, String str2) {
        if (this.enable) {
            Log.e("[Gorilla] ", String.format("%s %s", str, str2));
        }
    }
}
