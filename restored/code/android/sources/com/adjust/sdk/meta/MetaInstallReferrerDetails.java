package com.adjust.sdk.meta;

/* JADX INFO: loaded from: classes.dex */
public class MetaInstallReferrerDetails {
    public long actualTimestampInSec;
    public String installReferrer;
    public boolean isClick;

    MetaInstallReferrerDetails(String str, long j, boolean z) {
        this.installReferrer = str;
        this.actualTimestampInSec = j;
        this.isClick = z;
    }

    public String toString() {
        return com.adjust.sdk.Util.formatString(" installReferrer : %s actualTimestampInSec : %d isClick : %b", new Object[]{this.installReferrer, Long.valueOf(this.actualTimestampInSec), Boolean.valueOf(this.isClick)});
    }
}
