package com.byazt.hr;

import java.util.List;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 29, 13})
public class tt {
    public List<String> c;
    public List<String> tt;
    public long ve;

    public long c() {
        return this.ve;
    }

    public void c(long j) {
        this.ve = j;
    }

    public List<String> tt() {
        return this.c;
    }

    public void c(List<String> list) {
        this.c = list;
    }

    public List<String> ve() {
        return this.tt;
    }

    public void tt(List<String> list) {
        this.tt = list;
    }

    public String toString() {
        return "AdnLoadFailShowConfigBean{ breadRequestErrorCode=" + this.c + ",ritList=" + this.tt + ",breadRequestDuration=" + this.ve + " }";
    }
}
