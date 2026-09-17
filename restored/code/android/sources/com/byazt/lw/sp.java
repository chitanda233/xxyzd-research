package com.byazt.lw;

import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 2104, 91})
public class sp implements com.byazt.dr.c {
    public final Object c;

    public sp(String str) {
        if (str.equalsIgnoreCase("true")) {
            this.c = Boolean.TRUE;
        } else if (str.equalsIgnoreCase("false")) {
            this.c = Boolean.FALSE;
        } else {
            if (str.equalsIgnoreCase("null")) {
                this.c = null;
                return;
            }
            throw new IllegalArgumentException();
        }
    }

    @Override // com.byazt.dr.c
    public Object c(Map<String, JSONObject> map) {
        return this.c;
    }

    @Override // com.byazt.dr.c
    public com.byazt.zg.n c() {
        return com.byazt.zg.a.CONSTANT;
    }

    public String toString() {
        return "KeywordNode [keywordValue=" + this.c + "]";
    }

    @Override // com.byazt.dr.c
    public String tt() {
        Object obj = this.c;
        return obj != null ? obj.toString() : "NULL";
    }
}
