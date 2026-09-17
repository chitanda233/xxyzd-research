package com.gorilla.base.log;

/* JADX INFO: loaded from: classes3.dex */
public class LogFactory {
    private static ILogger logger;

    public static void enableLog(boolean z) {
        logger.setEnable(z);
    }

    public static ILogger getLogger() {
        if (logger == null) {
            logger = new DefaultLog();
        }
        return logger;
    }

    public static void setLogger(ILogger iLogger) {
        logger = iLogger;
    }
}
