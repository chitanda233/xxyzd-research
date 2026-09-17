package com.byazt.lw;

import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 2104, 117})
public class rl implements com.byazt.dr.c {
    public com.byazt.zg.uj c;

    public rl(com.byazt.zg.uj ujVar) {
        this.c = ujVar;
    }

    @Override // com.byazt.dr.c
    public Object c(Map<String, JSONObject> map) {
        throw new UnsupportedOperationException();
    }

    @Override // com.byazt.dr.c
    public com.byazt.zg.n c() {
        return this.c;
    }

    public String toString() {
        return tt();
    }

    @Override // com.byazt.dr.c
    public String tt() {
        return this.c.c();
    }
}
