package cn.thinkingdata.core.exception;

/* JADX INFO: loaded from: classes.dex */
public class TDHttpException extends Exception {
    public static final int ERROR_CONNECT_TIME_OUT = -10001;
    public static final int ERROR_EXCEPTION = -10002;
    public int errorCode;

    public TDHttpException(int i, String str) {
        super(str);
        this.errorCode = i;
    }
}
